# Fact ea754941

Store id: df62b4e7-47cc-4eec-b64d-c686e4fcd6c5

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
- posted_at: `2026-11-09T22:39:42.3310650+00:00`

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
  "id": "df62b4e7-47cc-4eec-b64d-c686e4fcd6c5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3310650+00:00"
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
  "subject_id": "c71db7c3-d4a0-4112-8b4c-711d6329141d",
  "subject_name": "django/db/models/fields/__init__::Field.unique",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def unique(self)"
}
```
