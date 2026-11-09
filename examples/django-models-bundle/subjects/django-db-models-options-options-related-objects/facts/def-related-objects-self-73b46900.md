# Fact 73b46900

Store id: 2794cd65-91a1-42ab-8e9f-28350e7a620e

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
- posted_at: `2026-11-09T23:32:03.9930280+00:00`

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
  "id": "2794cd65-91a1-42ab-8e9f-28350e7a620e",
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
    "posted_at": "2026-11-09T23:32:03.9930280+00:00"
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
  "subject_id": "cd0f7d18-4879-4bdf-98e2-c6ab456d2e92",
  "subject_name": "django/db/models/options::Options.related_objects",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def related_objects(self)"
}
```
