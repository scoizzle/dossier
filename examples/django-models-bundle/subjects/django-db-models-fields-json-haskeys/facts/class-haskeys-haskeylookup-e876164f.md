# Fact e876164f

Store id: cd72591c-d812-4f08-a394-280a4f31cf3b

## Text

```text
class HasKeys(HasKeyLookup)
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
- posted_at: `2026-11-09T22:39:43.6554910+00:00`

## Data

```json
{
  "end_line": 280,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 274,
  "symbol": "HasKeys"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":274,"selector":"L274-L280","symbol":"HasKeys"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeys](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 280,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 274,
    "symbol": "HasKeys"
  },
  "id": "cd72591c-d812-4f08-a394-280a4f31cf3b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6554910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 274,
        "selector": "L274-L280",
        "symbol": "HasKeys"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "090088c9-11e1-4a89-a74c-fe3a815bfc4b",
  "subject_name": "django/db/models/fields/json::HasKeys",
  "tags": [
    "entity:class"
  ],
  "text": "class HasKeys(HasKeyLookup)"
}
```
