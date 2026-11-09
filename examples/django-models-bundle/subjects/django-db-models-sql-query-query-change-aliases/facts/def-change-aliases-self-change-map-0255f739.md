# Fact 0255f739

Store id: 0b88a21b-348a-4e2a-854b-f012508c5a4b

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
- posted_at: `2026-11-09T23:44:58.7386040+00:00`

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
  "id": "0b88a21b-348a-4e2a-854b-f012508c5a4b",
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
    "posted_at": "2026-11-09T23:44:58.7386040+00:00"
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
  "subject_id": "67849b01-6d9f-4731-a668-2f2e42c2bcd2",
  "subject_name": "django/db/models/sql/query::Query.change_aliases",
  "tags": [
    "entity:method"
  ],
  "text": "def change_aliases(self, change_map)"
}
```
