# Fact 2a7b6abc

Store id: 7cbf5417-9dff-492e-ab8c-888ef2b784c1

## Text

```text
def many_to_many(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.9896420+00:00`

## Data

```json
{
  "end_line": 615,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 599,
  "symbol": "Options.many_to_many"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":599,"selector":"L599-L615","symbol":"Options.many_to_many"}`

## Items

```json
[
  {
    "text": "Return a list of all many to many fields on the model and its parents.",
    "locator": {
      "line": 601
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.many_to_many](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 615,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 599,
    "symbol": "Options.many_to_many"
  },
  "id": "7cbf5417-9dff-492e-ab8c-888ef2b784c1",
  "items": [
    {
      "locator": {
        "line": 601
      },
      "text": "Return a list of all many to many fields on the model and its parents."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9896420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 599,
        "selector": "L599-L615",
        "symbol": "Options.many_to_many"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "6cbfaf54-b23d-4dd2-a4fd-03e1722ee3ff",
  "subject_name": "django/db/models/options::Options.many_to_many",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def many_to_many(self)"
}
```
