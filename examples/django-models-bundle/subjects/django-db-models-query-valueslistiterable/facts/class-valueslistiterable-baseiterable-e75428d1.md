# Fact e75428d1

Store id: 578b1eb6-2fcd-4e28-9bea-6b7dbfc4d341

## Text

```text
class ValuesListIterable(BaseIterable)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.7968620+00:00`

## Data

```json
{
  "end_line": 301,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 287,
  "symbol": "ValuesListIterable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":287,"selector":"L287-L301","symbol":"ValuesListIterable"}`

## Items

```json
[
  {
    "text": "Iterable returned by QuerySet.values_list(flat=False) that yields a tuple for each row.",
    "locator": {
      "line": 288
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::ValuesListIterable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 301,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 287,
    "symbol": "ValuesListIterable"
  },
  "id": "578b1eb6-2fcd-4e28-9bea-6b7dbfc4d341",
  "items": [
    {
      "locator": {
        "line": 288
      },
      "text": "Iterable returned by QuerySet.values_list(flat=False) that yields a tuple for each row."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.7968620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 287,
        "selector": "L287-L301",
        "symbol": "ValuesListIterable"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "55dc4e26-a287-4cc9-943d-0377cf6b43a5",
  "subject_name": "django/db/models/query::ValuesListIterable",
  "tags": [
    "entity:class"
  ],
  "text": "class ValuesListIterable(BaseIterable)"
}
```
