# Fact abc66a46

Store id: c8d27be2-ab4e-4f4a-a572-49d585ebcc55

## Text

```text
class TruncTime(TruncBase)
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
- posted_at: `2026-11-09T22:39:46.2077560+00:00`

## Data

```json
{
  "end_line": 404,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 395,
  "symbol": "TruncTime"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":395,"selector":"L395-L404","symbol":"TruncTime"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncTime](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 404,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 395,
    "symbol": "TruncTime"
  },
  "id": "c8d27be2-ab4e-4f4a-a572-49d585ebcc55",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.2077560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 395,
        "selector": "L395-L404",
        "symbol": "TruncTime"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "6759186e-d42e-48da-a03f-369791ce5317",
  "subject_name": "django/db/models/functions/datetime::TruncTime",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncTime(TruncBase)"
}
```
