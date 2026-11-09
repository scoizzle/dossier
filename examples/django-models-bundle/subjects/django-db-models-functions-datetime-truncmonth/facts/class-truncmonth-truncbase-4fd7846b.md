# Fact 4fd7846b

Store id: 4013aad2-2059-4c25-bba0-70854341ea92

## Text

```text
class TruncMonth(TruncBase)
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
- posted_at: `2026-11-09T23:44:53.3987320+00:00`

## Data

```json
{
  "end_line": 370,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 369,
  "symbol": "TruncMonth"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":369,"selector":"L369-L370","symbol":"TruncMonth"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncMonth](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 370,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 369,
    "symbol": "TruncMonth"
  },
  "id": "4013aad2-2059-4c25-bba0-70854341ea92",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3987320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 369,
        "selector": "L369-L370",
        "symbol": "TruncMonth"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "ba875969-379e-4a0b-9a70-b0f84fae48b2",
  "subject_name": "django/db/models/functions/datetime::TruncMonth",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncMonth(TruncBase)"
}
```
