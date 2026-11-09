# Fact 55d21884

Store id: 70ec43da-718e-4e28-a9a1-81c310244e28

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
- posted_at: `2026-11-09T23:32:06.6688740+00:00`

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
  "id": "70ec43da-718e-4e28-a9a1-81c310244e28",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.6688740+00:00"
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
  "subject_id": "38e68cf6-6cdc-4b17-a83a-4981537e2607",
  "subject_name": "django/db/models/sql/query::get_children_from_q",
  "tags": [
    "entity:function"
  ],
  "text": "def get_children_from_q(q)"
}
```
