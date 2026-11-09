# Fact ea754941

Store id: 3c677f1c-8ce7-4971-9da3-45673d93daa4

## Text

```text
def unique(self)
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
- posted_at: `2026-11-09T23:31:56.4895220+00:00`

## Data

```json
{
  "end_line": 966,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 964,
  "symbol": "Field.unique"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":964,"selector":"L964-L966","symbol":"Field.unique"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.unique](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 966,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 964,
    "symbol": "Field.unique"
  },
  "id": "3c677f1c-8ce7-4971-9da3-45673d93daa4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4895220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 964,
        "selector": "L964-L966",
        "symbol": "Field.unique"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ac8bb09d-73ae-46a8-bf56-17a7b151649e",
  "subject_name": "django/db/models/fields/__init__::Field.unique",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def unique(self)"
}
```
