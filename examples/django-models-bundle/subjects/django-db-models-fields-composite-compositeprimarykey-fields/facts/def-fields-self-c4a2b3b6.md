# Fact c4a2b3b6

Store id: 04dc0fbd-0b69-476c-b4c3-8ab7ab7bfbd4

## Text

```text
def fields(self)
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
- posted_at: `2026-11-09T22:39:42.9969080+00:00`

## Data

```json
{
  "end_line": 86,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 83,
  "symbol": "CompositePrimaryKey.fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":83,"selector":"L83-L86","symbol":"CompositePrimaryKey.fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 86,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 83,
    "symbol": "CompositePrimaryKey.fields"
  },
  "id": "04dc0fbd-0b69-476c-b4c3-8ab7ab7bfbd4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.9969080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 83,
        "selector": "L83-L86",
        "symbol": "CompositePrimaryKey.fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "6d3bd8f0-0a18-49e7-93c8-52526bba08a9",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def fields(self)"
}
```
