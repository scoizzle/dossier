# Fact 2b415402

Store id: 631b21fd-5c8e-42f8-9094-b0e7e48707ea

## Text

```text
def _execute_query(self)
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
- posted_at: `2026-11-09T23:32:06.7359910+00:00`

## Data

```json
{
  "end_line": 225,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 208,
  "symbol": "RawQuery._execute_query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":208,"selector":"L208-L225","symbol":"RawQuery._execute_query"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery._execute_query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 225,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 208,
    "symbol": "RawQuery._execute_query"
  },
  "id": "631b21fd-5c8e-42f8-9094-b0e7e48707ea",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7359910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 208,
        "selector": "L208-L225",
        "symbol": "RawQuery._execute_query"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "6e362afb-a4be-4c72-b305-ae041d4fee51",
  "subject_name": "django/db/models/sql/query::RawQuery._execute_query",
  "tags": [
    "entity:method"
  ],
  "text": "def _execute_query(self)"
}
```
