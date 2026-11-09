# Fact 0255f739

Store id: 24dea3bd-2f0e-4fd6-aade-496fe22d472a

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
- posted_at: `2026-11-09T23:32:06.8541810+00:00`

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
  "id": "24dea3bd-2f0e-4fd6-aade-496fe22d472a",
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
    "posted_at": "2026-11-09T23:32:06.8541810+00:00"
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
  "subject_id": "dcf3ca1c-b6f8-4eab-9b39-542992b55f20",
  "subject_name": "django/db/models/sql/query::Query.change_aliases",
  "tags": [
    "entity:method"
  ],
  "text": "def change_aliases(self, change_map)"
}
```
