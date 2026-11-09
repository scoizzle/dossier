# Fact 53b22c36

Store id: f4729580-aafb-4980-9317-351fc6717e2c

## Text

```text
class Substr(Func)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:54.1629850+00:00`

## Data

```json
{
  "end_line": 367,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 345,
  "symbol": "Substr"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":345,"selector":"L345-L367","symbol":"Substr"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Substr](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 367,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 345,
    "symbol": "Substr"
  },
  "id": "f4729580-aafb-4980-9317-351fc6717e2c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1629850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 345,
        "selector": "L345-L367",
        "symbol": "Substr"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "3dbc402f-a8b5-48ad-841f-1d08257d6adc",
  "subject_name": "django/db/models/functions/text::Substr",
  "tags": [
    "entity:class"
  ],
  "text": "class Substr(Func)"
}
```
