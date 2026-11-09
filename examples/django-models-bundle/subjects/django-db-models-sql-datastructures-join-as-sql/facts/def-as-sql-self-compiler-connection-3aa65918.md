# Fact 3aa65918

Store id: 2011308c-fc35-4ca5-abb1-2859033c727c

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:58.2040680+00:00`

## Data

```json
{
  "end_line": 133,
  "entity_kind": "method",
  "parent": "Join",
  "start_line": 76,
  "symbol": "Join.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":76,"selector":"L76-L133","symbol":"Join.as_sql"}`

## Items

```json
[
  {
    "text": "Generate the full LEFT OUTER JOIN sometable ON sometable.somecol = othertable.othercol, params clause for this join.",
    "locator": {
      "line": 77
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::Join.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 133,
    "entity_kind": "method",
    "parent": "Join",
    "start_line": 76,
    "symbol": "Join.as_sql"
  },
  "id": "2011308c-fc35-4ca5-abb1-2859033c727c",
  "items": [
    {
      "locator": {
        "line": 77
      },
      "text": "Generate the full LEFT OUTER JOIN sometable ON sometable.somecol = othertable.othercol, params clause for this join."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.2040680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 76,
        "selector": "L76-L133",
        "symbol": "Join.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "f7509e88-31fa-474b-8de4-f64eb0741e96",
  "subject_name": "django/db/models/sql/datastructures::Join.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
