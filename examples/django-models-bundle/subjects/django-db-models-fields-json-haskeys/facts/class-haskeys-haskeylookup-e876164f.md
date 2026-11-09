# Fact e876164f

Store id: 9b6b52ea-2be3-4d83-814b-88090ec7e1d5

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
- posted_at: `2026-11-09T23:44:50.9753960+00:00`

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
  "id": "9b6b52ea-2be3-4d83-814b-88090ec7e1d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9753960+00:00"
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
  "subject_id": "280b8fab-5a9d-4e75-b5fd-7899fb257f49",
  "subject_name": "django/db/models/fields/json::HasKeys",
  "tags": [
    "entity:class"
  ],
  "text": "class HasKeys(HasKeyLookup)"
}
```
