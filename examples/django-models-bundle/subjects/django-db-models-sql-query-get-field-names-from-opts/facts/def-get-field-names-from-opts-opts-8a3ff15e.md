# Fact 8a3ff15e

Store id: 7ccb8869-8875-43f7-ac6e-95b415d210bf

## Text

```text
def get_field_names_from_opts(opts)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:58.4729360+00:00`

## Data

```json
{
  "end_line": 78,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 71,
  "symbol": "get_field_names_from_opts"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":71,"selector":"L71-L78","symbol":"get_field_names_from_opts"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::get_field_names_from_opts](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 78,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 71,
    "symbol": "get_field_names_from_opts"
  },
  "id": "7ccb8869-8875-43f7-ac6e-95b415d210bf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.4729360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 71,
        "selector": "L71-L78",
        "symbol": "get_field_names_from_opts"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "30b75681-82c6-4896-9eb0-6b941083e6b9",
  "subject_name": "django/db/models/sql/query::get_field_names_from_opts",
  "tags": [
    "entity:function"
  ],
  "text": "def get_field_names_from_opts(opts)"
}
```
