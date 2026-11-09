# Fact 29199708

Store id: dba34e98-461a-45a7-85d1-67ccc3426959

## Text

```text
class KeyTransform(ProcessJSONLHSMixin, Transform)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:43.7034340+00:00`

## Data

```json
{
  "end_line": 537,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 496,
  "symbol": "KeyTransform"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":496,"selector":"L496-L537","symbol":"KeyTransform"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransform](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 537,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 496,
    "symbol": "KeyTransform"
  },
  "id": "dba34e98-461a-45a7-85d1-67ccc3426959",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7034340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 496,
        "selector": "L496-L537",
        "symbol": "KeyTransform"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "237f30bf-5e84-47e7-abb3-d55f66f98945",
  "subject_name": "django/db/models/fields/json::KeyTransform",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransform(ProcessJSONLHSMixin, Transform)"
}
```
