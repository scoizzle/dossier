# Fact 6f92ae87

Store id: da27ac79-a135-4b73-b5cd-9d721bae0ea6

## Text

```text
def __getitem__(self, k)
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
- posted_at: `2026-11-09T23:44:55.8625630+00:00`

## Data

```json
{
  "end_line": 525,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 490,
  "symbol": "QuerySet.__getitem__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":490,"selector":"L490-L525","symbol":"QuerySet.__getitem__"}`

## Items

```json
[
  {
    "text": "Retrieve an item or slice from the set of results.",
    "locator": {
      "line": 491
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__getitem__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 525,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 490,
    "symbol": "QuerySet.__getitem__"
  },
  "id": "da27ac79-a135-4b73-b5cd-9d721bae0ea6",
  "items": [
    {
      "locator": {
        "line": 491
      },
      "text": "Retrieve an item or slice from the set of results."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8625630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 490,
        "selector": "L490-L525",
        "symbol": "QuerySet.__getitem__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "dedd9523-b8f4-4ba9-9666-cea22cc46c79",
  "subject_name": "django/db/models/query::QuerySet.__getitem__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getitem__(self, k)"
}
```
