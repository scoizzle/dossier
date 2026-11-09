# Fact 8bfed0dc

Store id: 2033161b-8790-4b65-9d30-da00882a661a

## Text

```text
class NamedValuesListIterable(ValuesListIterable)
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
- posted_at: `2026-11-09T23:32:04.2747850+00:00`

## Data

```json
{
  "end_line": 324,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 304,
  "symbol": "NamedValuesListIterable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":304,"selector":"L304-L324","symbol":"NamedValuesListIterable"}`

## Items

```json
[
  {
    "text": "Iterable returned by QuerySet.values_list(named=True) that yields a namedtuple for each row.",
    "locator": {
      "line": 305
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::NamedValuesListIterable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 324,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 304,
    "symbol": "NamedValuesListIterable"
  },
  "id": "2033161b-8790-4b65-9d30-da00882a661a",
  "items": [
    {
      "locator": {
        "line": 305
      },
      "text": "Iterable returned by QuerySet.values_list(named=True) that yields a namedtuple for each row."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2747850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 304,
        "selector": "L304-L324",
        "symbol": "NamedValuesListIterable"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "50b003ba-5d84-4b08-bde1-b48a86a8fc4c",
  "subject_name": "django/db/models/query::NamedValuesListIterable",
  "tags": [
    "entity:class"
  ],
  "text": "class NamedValuesListIterable(ValuesListIterable)"
}
```
