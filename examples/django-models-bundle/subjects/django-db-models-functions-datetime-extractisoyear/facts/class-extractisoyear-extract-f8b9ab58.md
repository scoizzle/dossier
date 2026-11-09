# Fact f8b9ab58

Store id: 4c2f001c-c9ce-400d-91b3-b0b5f3a6ae48

## Text

```text
class ExtractIsoYear(Extract)
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
- posted_at: `2026-11-09T23:32:01.1832000+00:00`

## Data

```json
{
  "end_line": 131,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 128,
  "symbol": "ExtractIsoYear"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":128,"selector":"L128-L131","symbol":"ExtractIsoYear"}`

## Items

```json
[
  {
    "text": "Return the ISO-8601 week-numbering year.",
    "locator": {
      "line": 129
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractIsoYear](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 131,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 128,
    "symbol": "ExtractIsoYear"
  },
  "id": "4c2f001c-c9ce-400d-91b3-b0b5f3a6ae48",
  "items": [
    {
      "locator": {
        "line": 129
      },
      "text": "Return the ISO-8601 week-numbering year."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.1832000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 128,
        "selector": "L128-L131",
        "symbol": "ExtractIsoYear"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "40b71435-29d2-4c0e-94d1-b5ba46388e31",
  "subject_name": "django/db/models/functions/datetime::ExtractIsoYear",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractIsoYear(Extract)"
}
```
