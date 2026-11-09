# Fact 2a7b6abc

Store id: 8f5009c8-2915-4658-a79b-ad28458e0c72

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
- posted_at: `2026-11-09T22:39:48.8554320+00:00`

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
  "id": "8f5009c8-2915-4658-a79b-ad28458e0c72",
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
    "posted_at": "2026-11-09T22:39:48.8554320+00:00"
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
  "subject_id": "a54bf4f0-10d3-4f6b-9389-0a9d52bef166",
  "subject_name": "django/db/models/options::Options.many_to_many",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def many_to_many(self)"
}
```
