# Fact 55d21884

Store id: 36acc3d8-89ed-4995-806e-bad87162b456

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
- posted_at: `2026-11-09T22:39:51.1604320+00:00`

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
  "id": "36acc3d8-89ed-4995-806e-bad87162b456",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.1604320+00:00"
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
  "subject_id": "95245811-987a-461d-b1fb-4b571d17e9cf",
  "subject_name": "django/db/models/sql/query::get_children_from_q",
  "tags": [
    "entity:function"
  ],
  "text": "def get_children_from_q(q)"
}
```
