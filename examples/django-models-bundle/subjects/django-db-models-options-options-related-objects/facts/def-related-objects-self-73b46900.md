# Fact 73b46900

Store id: db8985c5-2ad5-4c89-a2de-3e12131ba2d2

## Text

```text
def related_objects(self)
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
- posted_at: `2026-11-09T23:44:55.5437490+00:00`

## Data

```json
{
  "end_line": 638,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 617,
  "symbol": "Options.related_objects"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":617,"selector":"L617-L638","symbol":"Options.related_objects"}`

## Items

```json
[
  {
    "text": "Return all related objects pointing to the current model. The related objects can come from a one-to-one, one-to-many, or many-to-many field relation type.",
    "locator": {
      "line": 619
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.related_objects](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 638,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 617,
    "symbol": "Options.related_objects"
  },
  "id": "db8985c5-2ad5-4c89-a2de-3e12131ba2d2",
  "items": [
    {
      "locator": {
        "line": 619
      },
      "text": "Return all related objects pointing to the current model. The related objects can come from a one-to-one, one-to-many, or many-to-many field relation type."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5437490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 617,
        "selector": "L617-L638",
        "symbol": "Options.related_objects"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "72064a81-adaf-4a86-b7e9-f3959a8bca76",
  "subject_name": "django/db/models/options::Options.related_objects",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def related_objects(self)"
}
```
