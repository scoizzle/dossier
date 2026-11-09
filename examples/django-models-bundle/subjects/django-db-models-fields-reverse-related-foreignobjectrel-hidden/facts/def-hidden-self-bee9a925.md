# Fact bee9a925

Store id: c10cec01-85c8-4d9f-9ef8-60e44384061c

## Text

```text
def hidden(self)
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
- posted_at: `2026-11-09T22:39:45.2865430+00:00`

## Data

```json
{
  "end_line": 67,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 64,
  "symbol": "ForeignObjectRel.hidden"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":64,"selector":"L64-L67","symbol":"ForeignObjectRel.hidden"}`

## Items

```json
[
  {
    "text": "Should the related object be hidden?",
    "locator": {
      "line": 66
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.hidden](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 67,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 64,
    "symbol": "ForeignObjectRel.hidden"
  },
  "id": "c10cec01-85c8-4d9f-9ef8-60e44384061c",
  "items": [
    {
      "locator": {
        "line": 66
      },
      "text": "Should the related object be hidden?"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.2865430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 64,
        "selector": "L64-L67",
        "symbol": "ForeignObjectRel.hidden"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "2426fbb3-1d7e-4344-ab33-304bd160f46d",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.hidden",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def hidden(self)"
}
```
