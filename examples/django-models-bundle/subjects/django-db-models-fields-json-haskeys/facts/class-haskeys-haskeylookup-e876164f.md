# Fact e876164f

Store id: e2dedaef-fd3b-454a-93bd-120c97291e45

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
- posted_at: `2026-11-09T23:31:57.8999660+00:00`

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
  "id": "e2dedaef-fd3b-454a-93bd-120c97291e45",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8999660+00:00"
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
  "subject_id": "fc91d6ce-55ac-4430-b846-2758686b1020",
  "subject_name": "django/db/models/fields/json::HasKeys",
  "tags": [
    "entity:class"
  ],
  "text": "class HasKeys(HasKeyLookup)"
}
```
