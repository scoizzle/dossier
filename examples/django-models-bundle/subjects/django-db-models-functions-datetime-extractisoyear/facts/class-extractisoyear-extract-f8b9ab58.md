# Fact f8b9ab58

Store id: 3daa1acc-3604-450b-9aaf-8bdca498955d

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
- posted_at: `2026-11-09T22:39:46.1168640+00:00`

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
  "id": "3daa1acc-3604-450b-9aaf-8bdca498955d",
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
    "posted_at": "2026-11-09T22:39:46.1168640+00:00"
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
  "subject_id": "028500fb-2b3d-4b7a-a530-560ae71c2338",
  "subject_name": "django/db/models/functions/datetime::ExtractIsoYear",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractIsoYear(Extract)"
}
```
