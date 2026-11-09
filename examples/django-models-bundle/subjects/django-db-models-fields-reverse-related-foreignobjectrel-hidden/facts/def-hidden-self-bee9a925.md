# Fact bee9a925

Store id: df7dd292-c97b-47fb-b406-64ce42e4b984

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
- posted_at: `2026-11-09T23:44:52.4235550+00:00`

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
  "id": "df7dd292-c97b-47fb-b406-64ce42e4b984",
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
    "posted_at": "2026-11-09T23:44:52.4235550+00:00"
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
  "subject_id": "da563f8d-f0e3-4113-be49-f5f020ef44e4",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.hidden",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def hidden(self)"
}
```
