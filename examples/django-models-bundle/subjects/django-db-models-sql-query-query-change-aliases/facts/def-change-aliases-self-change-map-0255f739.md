# Fact 0255f739

Store id: f24f7fad-5382-4aa4-94d4-5442284e8ee6

## Text

```text
def change_aliases(self, change_map)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.3060150+00:00`

## Data

```json
{
  "end_line": 1055,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1000,
  "symbol": "Query.change_aliases"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1000,"selector":"L1000-L1055","symbol":"Query.change_aliases"}`

## Items

```json
[
  {
    "text": "Change the aliases in change_map (which maps old-alias -> new-alias), relabelling any references to them in select columns and the where clause.",
    "locator": {
      "line": 1001
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.change_aliases](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1055,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1000,
    "symbol": "Query.change_aliases"
  },
  "id": "f24f7fad-5382-4aa4-94d4-5442284e8ee6",
  "items": [
    {
      "locator": {
        "line": 1001
      },
      "text": "Change the aliases in change_map (which maps old-alias -> new-alias), relabelling any references to them in select columns and the where clause."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3060150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1000,
        "selector": "L1000-L1055",
        "symbol": "Query.change_aliases"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2ea83f75-7537-4b23-b7fe-9c1c290f3874",
  "subject_name": "django/db/models/sql/query::Query.change_aliases",
  "tags": [
    "entity:method"
  ],
  "text": "def change_aliases(self, change_map)"
}
```
