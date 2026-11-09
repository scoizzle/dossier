# Fact 9d8a22ba

Store id: 7a972ea6-80a9-4b16-b83e-3867bbadb271

## Text

```text
def get_prefetcher(instance, through_attr, to_attr)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.3150500+00:00`

## Data

```json
{
  "end_line": 2871,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 2809,
  "symbol": "get_prefetcher"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2809,"selector":"L2809-L2871","symbol":"get_prefetcher"}`

## Items

```json
[
  {
    "text": "For the attribute 'through_attr' on the given instance, find an object that has a get_prefetch_querysets(). Return a 4 tuple containing: (the object with get_prefetch_querysets (or None), the descriptor object representing this relationship (or None), a boolean that is False if the attribute was not found at all, a function that takes an instance and returns a boolean that is True if the attribute has already been fetched for that instance)",
    "locator": {
      "line": 2810
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::get_prefetcher](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2871,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 2809,
    "symbol": "get_prefetcher"
  },
  "id": "7a972ea6-80a9-4b16-b83e-3867bbadb271",
  "items": [
    {
      "locator": {
        "line": 2810
      },
      "text": "For the attribute 'through_attr' on the given instance, find an object that has a get_prefetch_querysets(). Return a 4 tuple containing: (the object with get_prefetch_querysets (or None), the descriptor object representing this relationship (or None), a boolean that is False if the attribute was not found at all, a function that takes an instance and returns a boolean that is True if the attribute has already been fetched for that instance)"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.3150500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2809,
        "selector": "L2809-L2871",
        "symbol": "get_prefetcher"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2c836d2c-fb9e-499d-83e8-6ad825277d8f",
  "subject_name": "django/db/models/query::get_prefetcher",
  "tags": [
    "entity:function"
  ],
  "text": "def get_prefetcher(instance, through_attr, to_attr)"
}
```
