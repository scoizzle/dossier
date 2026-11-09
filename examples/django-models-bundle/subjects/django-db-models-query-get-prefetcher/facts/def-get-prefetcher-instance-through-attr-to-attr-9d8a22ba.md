# Fact 9d8a22ba

Store id: da924aaf-36e6-47c3-a7e7-bcc33c63a618

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
- posted_at: `2026-11-09T22:39:49.8794400+00:00`

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
  "id": "da924aaf-36e6-47c3-a7e7-bcc33c63a618",
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
    "posted_at": "2026-11-09T22:39:49.8794400+00:00"
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
  "subject_id": "b176ce71-15f0-41e4-a604-79c75b5397af",
  "subject_name": "django/db/models/query::get_prefetcher",
  "tags": [
    "entity:function"
  ],
  "text": "def get_prefetcher(instance, through_attr, to_attr)"
}
```
