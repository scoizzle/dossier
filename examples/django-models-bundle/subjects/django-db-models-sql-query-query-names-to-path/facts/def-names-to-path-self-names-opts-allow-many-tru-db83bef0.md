# Fact db83bef0

Store id: a275fcef-f724-4925-807a-2c959117e568

## Text

```text
def names_to_path(self, names, opts, allow_many=True, fail_on_missing=False)
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
- posted_at: `2026-11-09T23:32:06.9614280+00:00`

## Data

```json
{
  "end_line": 1888,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1774,
  "symbol": "Query.names_to_path"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1774,"selector":"L1774-L1888","symbol":"Query.names_to_path"}`

## Items

```json
[
  {
    "text": "Walk the list of names and turns them into PathInfo tuples. A single name in 'names' can generate multiple PathInfos (m2m, for example).",
    "locator": {
      "line": 1775
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.names_to_path](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1888,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1774,
    "symbol": "Query.names_to_path"
  },
  "id": "a275fcef-f724-4925-807a-2c959117e568",
  "items": [
    {
      "locator": {
        "line": 1775
      },
      "text": "Walk the list of names and turns them into PathInfo tuples. A single name in 'names' can generate multiple PathInfos (m2m, for example)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.9614280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1774,
        "selector": "L1774-L1888",
        "symbol": "Query.names_to_path"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5cc9fc72-8d88-43d1-b514-97294a7cb641",
  "subject_name": "django/db/models/sql/query::Query.names_to_path",
  "tags": [
    "entity:method"
  ],
  "text": "def names_to_path(self, names, opts, allow_many=True, fail_on_missing=False)"
}
```
