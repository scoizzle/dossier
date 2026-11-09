# Fact 6f92ae87

Store id: b9fa7213-81e8-454d-87b8-ae938ab393b4

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
- posted_at: `2026-11-09T23:32:04.3442460+00:00`

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
  "id": "b9fa7213-81e8-454d-87b8-ae938ab393b4",
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
    "posted_at": "2026-11-09T23:32:04.3442460+00:00"
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
  "subject_id": "5d065268-12aa-41e9-a0d5-fe7b6d232b71",
  "subject_name": "django/db/models/query::QuerySet.__getitem__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getitem__(self, k)"
}
```
