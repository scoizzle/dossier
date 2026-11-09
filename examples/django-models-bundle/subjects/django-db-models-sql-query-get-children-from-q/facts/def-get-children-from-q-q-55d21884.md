# Fact 55d21884

Store id: b9d55968-6b9b-42f0-87c5-76be98fe9eec

## Text

```text
def get_children_from_q(q)
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
- posted_at: `2026-11-09T23:44:58.4989220+00:00`

## Data

```json
{
  "end_line": 102,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 92,
  "symbol": "get_children_from_q"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":92,"selector":"L92-L102","symbol":"get_children_from_q"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::get_children_from_q](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 102,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 92,
    "symbol": "get_children_from_q"
  },
  "id": "b9d55968-6b9b-42f0-87c5-76be98fe9eec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.4989220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 92,
        "selector": "L92-L102",
        "symbol": "get_children_from_q"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d023db1a-dbf8-4ed8-a289-93ad36398bf2",
  "subject_name": "django/db/models/sql/query::get_children_from_q",
  "tags": [
    "entity:function"
  ],
  "text": "def get_children_from_q(q)"
}
```
