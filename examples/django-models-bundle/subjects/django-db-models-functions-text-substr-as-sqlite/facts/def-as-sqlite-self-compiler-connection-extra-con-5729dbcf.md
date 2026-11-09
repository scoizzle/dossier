# Fact 5729dbcf

Store id: 4dfa6c80-1a6a-40d6-980b-6c9c5e0302e1

## Text

```text
def as_sqlite(self, compiler, connection, **extra_context)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:47.2115550+00:00`

## Data

```json
{
  "end_line": 364,
  "entity_kind": "method",
  "parent": "Substr",
  "start_line": 363,
  "symbol": "Substr.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":363,"selector":"L363-L364","symbol":"Substr.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Substr.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 364,
    "entity_kind": "method",
    "parent": "Substr",
    "start_line": 363,
    "symbol": "Substr.as_sqlite"
  },
  "id": "4dfa6c80-1a6a-40d6-980b-6c9c5e0302e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.2115550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 363,
        "selector": "L363-L364",
        "symbol": "Substr.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "00483263-d5d9-4c1d-a453-2ce34112580d",
  "subject_name": "django/db/models/functions/text::Substr.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
