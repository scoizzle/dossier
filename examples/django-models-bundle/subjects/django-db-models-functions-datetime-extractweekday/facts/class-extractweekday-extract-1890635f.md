# Fact 1890635f

Store id: cf2eadd9-c976-44b1-8b0d-1e8d5f644718

## Text

```text
class ExtractWeekDay(Extract)
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
- posted_at: `2026-11-09T22:39:46.1421970+00:00`

## Data

```json
{
  "end_line": 158,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 151,
  "symbol": "ExtractWeekDay"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":151,"selector":"L151-L158","symbol":"ExtractWeekDay"}`

## Items

```json
[
  {
    "text": "Return Sunday=1 through Saturday=7.",
    "locator": {
      "line": 152
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractWeekDay](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 158,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 151,
    "symbol": "ExtractWeekDay"
  },
  "id": "cf2eadd9-c976-44b1-8b0d-1e8d5f644718",
  "items": [
    {
      "locator": {
        "line": 152
      },
      "text": "Return Sunday=1 through Saturday=7."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1421970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 151,
        "selector": "L151-L158",
        "symbol": "ExtractWeekDay"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "b6d16c1e-2126-4f47-984c-d21a66e24590",
  "subject_name": "django/db/models/functions/datetime::ExtractWeekDay",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractWeekDay(Extract)"
}
```
