# Fact 5729dbcf

Store id: 3480988e-d4d3-44d7-92c5-29086d6cf7ce

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
- posted_at: `2026-11-09T23:32:02.3113740+00:00`

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
  "id": "3480988e-d4d3-44d7-92c5-29086d6cf7ce",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.3113740+00:00"
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
  "subject_id": "0f1292fd-6428-4a66-a66a-140f5bfbbd45",
  "subject_name": "django/db/models/functions/text::Substr.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
