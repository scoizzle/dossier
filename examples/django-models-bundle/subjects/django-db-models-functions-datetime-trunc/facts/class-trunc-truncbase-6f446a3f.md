# Fact 6f446a3f

Store id: 8af93910-66bb-41ee-b479-4a50a8722b21

## Text

```text
class Trunc(TruncBase)
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
- posted_at: `2026-11-09T23:32:01.2659930+00:00`

## Data

```json
{
  "end_line": 358,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 348,
  "symbol": "Trunc"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":348,"selector":"L348-L358","symbol":"Trunc"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Trunc](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 358,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 348,
    "symbol": "Trunc"
  },
  "id": "8af93910-66bb-41ee-b479-4a50a8722b21",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2659930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 348,
        "selector": "L348-L358",
        "symbol": "Trunc"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "f1377718-d97e-45bd-923d-680a1a212e0f",
  "subject_name": "django/db/models/functions/datetime::Trunc",
  "tags": [
    "entity:class"
  ],
  "text": "class Trunc(TruncBase)"
}
```
