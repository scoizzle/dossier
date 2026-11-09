# Fact 29199708

Store id: 065fb3c7-411e-4193-ba4d-a504d0f8ca82

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
- posted_at: `2026-11-09T23:31:57.9600220+00:00`

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
  "id": "065fb3c7-411e-4193-ba4d-a504d0f8ca82",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9600220+00:00"
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
  "subject_id": "9476ef9e-8916-4271-8b27-5ef680e29e6f",
  "subject_name": "django/db/models/fields/json::KeyTransform",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransform(ProcessJSONLHSMixin, Transform)"
}
```
