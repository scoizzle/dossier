# Fact 8277214d

Store id: cb610973-078e-40a4-b9b5-5037f61df70a

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
- posted_at: `2026-11-09T23:31:57.9775630+00:00`

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
  "id": "cb610973-078e-40a4-b9b5-5037f61df70a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9775630+00:00"
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
  "subject_id": "0664eb1a-156b-45e8-902f-686290a98d2f",
  "subject_name": "django/db/models/fields/json::KeyTextTransform",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTextTransform(KeyTransform)"
}
```
