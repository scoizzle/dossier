# Fact 4a2e91a5

Store id: 6ae3a3a3-ab92-4c7f-b7c1-47cbd4af46d6

## Text

```text
def __deepcopy__(self, memo)
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
- posted_at: `2026-11-09T23:44:58.6116790+00:00`

## Data

```json
{
  "end_line": 367,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 363,
  "symbol": "Query.__deepcopy__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":363,"selector":"L363-L367","symbol":"Query.__deepcopy__"}`

## Items

```json
[
  {
    "text": "Limit the amount of work when a Query is deepcopied.",
    "locator": {
      "line": 364
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.__deepcopy__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 367,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 363,
    "symbol": "Query.__deepcopy__"
  },
  "id": "6ae3a3a3-ab92-4c7f-b7c1-47cbd4af46d6",
  "items": [
    {
      "locator": {
        "line": 364
      },
      "text": "Limit the amount of work when a Query is deepcopied."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.6116790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 363,
        "selector": "L363-L367",
        "symbol": "Query.__deepcopy__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "880e940d-82bf-4e34-89c9-5bad46507150",
  "subject_name": "django/db/models/sql/query::Query.__deepcopy__",
  "tags": [
    "entity:method"
  ],
  "text": "def __deepcopy__(self, memo)"
}
```
