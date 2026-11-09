# Fact df94810c

Store id: 142ea4de-e320-4eeb-991b-5371cffe4fda

## Text

```text
class EmptyQuerySet(metaclass=InstanceCheckMeta)
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
- posted_at: `2026-11-09T23:44:56.2045790+00:00`

## Data

```json
{
  "end_line": 2407,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 2400,
  "symbol": "EmptyQuerySet"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2400,"selector":"L2400-L2407","symbol":"EmptyQuerySet"}`

## Items

```json
[
  {
    "text": "Marker class to checking if a queryset is empty by .none(): isinstance(qs.none(), EmptyQuerySet) -> True",
    "locator": {
      "line": 2401
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::EmptyQuerySet](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2407,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 2400,
    "symbol": "EmptyQuerySet"
  },
  "id": "142ea4de-e320-4eeb-991b-5371cffe4fda",
  "items": [
    {
      "locator": {
        "line": 2401
      },
      "text": "Marker class to checking if a queryset is empty by .none(): isinstance(qs.none(), EmptyQuerySet) -> True"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2045790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2400,
        "selector": "L2400-L2407",
        "symbol": "EmptyQuerySet"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "b61c174f-638a-4190-afda-c90ec562fde2",
  "subject_name": "django/db/models/query::EmptyQuerySet",
  "tags": [
    "entity:class"
  ],
  "text": "class EmptyQuerySet(metaclass=InstanceCheckMeta)"
}
```
