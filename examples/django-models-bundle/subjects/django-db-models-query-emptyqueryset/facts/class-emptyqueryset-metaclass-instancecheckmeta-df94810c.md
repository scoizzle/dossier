# Fact df94810c

Store id: 0e9b17b2-c76c-4ee3-be11-fab467a257f1

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
- posted_at: `2026-11-09T22:39:49.7615590+00:00`

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
  "id": "0e9b17b2-c76c-4ee3-be11-fab467a257f1",
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
    "posted_at": "2026-11-09T22:39:49.7615590+00:00"
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
  "subject_id": "9184f5a0-d0f2-4f9f-8274-7b08643a55a8",
  "subject_name": "django/db/models/query::EmptyQuerySet",
  "tags": [
    "entity:class"
  ],
  "text": "class EmptyQuerySet(metaclass=InstanceCheckMeta)"
}
```
