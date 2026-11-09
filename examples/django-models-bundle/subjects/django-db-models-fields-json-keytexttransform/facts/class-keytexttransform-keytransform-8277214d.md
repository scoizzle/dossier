# Fact 8277214d

Store id: 84832053-59f7-4200-ae17-5156fbca5c76

## Text

```text
class KeyTextTransform(KeyTransform)
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
- posted_at: `2026-11-09T23:44:51.0281550+00:00`

## Data

```json
{
  "end_line": 566,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 540,
  "symbol": "KeyTextTransform"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":540,"selector":"L540-L566","symbol":"KeyTextTransform"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTextTransform](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 566,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 540,
    "symbol": "KeyTextTransform"
  },
  "id": "84832053-59f7-4200-ae17-5156fbca5c76",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0281550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 540,
        "selector": "L540-L566",
        "symbol": "KeyTextTransform"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "cb7f1038-02df-4659-935f-1c767f1e425d",
  "subject_name": "django/db/models/fields/json::KeyTextTransform",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTextTransform(KeyTransform)"
}
```
