# Fact ae5327cc

Store id: 80f2a6d8-8109-4827-99b1-d91073cdd2e2

## Text

```text
def get_initial_alias(self)
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
- posted_at: `2026-11-09T23:32:06.8660260+00:00`

## Data

```json
{
  "end_line": 1124,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1112,
  "symbol": "Query.get_initial_alias"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1112,"selector":"L1112-L1124","symbol":"Query.get_initial_alias"}`

## Items

```json
[
  {
    "text": "Return the first alias for this query, after increasing its reference count.",
    "locator": {
      "line": 1113
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.get_initial_alias](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1124,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1112,
    "symbol": "Query.get_initial_alias"
  },
  "id": "80f2a6d8-8109-4827-99b1-d91073cdd2e2",
  "items": [
    {
      "locator": {
        "line": 1113
      },
      "text": "Return the first alias for this query, after increasing its reference count."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.8660260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1112,
        "selector": "L1112-L1124",
        "symbol": "Query.get_initial_alias"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "b18c2330-8123-46fd-ad0c-dadf08762c21",
  "subject_name": "django/db/models/sql/query::Query.get_initial_alias",
  "tags": [
    "entity:method"
  ],
  "text": "def get_initial_alias(self)"
}
```
