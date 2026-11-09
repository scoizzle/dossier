# Fact 69af56e0

Store id: fb40bae7-4d7d-410b-b311-4d4cc4a4bbae

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T23:32:06.7584460+00:00`

## Data

```json
{
  "end_line": 354,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 345,
  "symbol": "Query.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":345,"selector":"L345-L354","symbol":"Query.__str__"}`

## Items

```json
[
  {
    "text": "Return the query as a string of SQL with the parameter values substituted in (use sql_with_params() to see the unsubstituted string).",
    "locator": {
      "line": 346
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 354,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 345,
    "symbol": "Query.__str__"
  },
  "id": "fb40bae7-4d7d-410b-b311-4d4cc4a4bbae",
  "items": [
    {
      "locator": {
        "line": 346
      },
      "text": "Return the query as a string of SQL with the parameter values substituted in (use sql_with_params() to see the unsubstituted string)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7584460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 345,
        "selector": "L345-L354",
        "symbol": "Query.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "7b5919eb-c6c9-4f62-8432-b69b60e03624",
  "subject_name": "django/db/models/sql/query::Query.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
