# Fact d95bb1e8

Store id: 8df403a2-adc7-4ace-a79e-40af2540d310

## Text

```text
class ProtectedError(IntegrityError)
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
- posted_at: `2026-11-09T22:39:40.9472640+00:00`

## Data

```json
{
  "end_line": 13,
  "entity_kind": "class",
  "parent": "deletion",
  "start_line": 10,
  "symbol": "ProtectedError"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":10,"selector":"L10-L13","symbol":"ProtectedError"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::ProtectedError](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 13,
    "entity_kind": "class",
    "parent": "deletion",
    "start_line": 10,
    "symbol": "ProtectedError"
  },
  "id": "8df403a2-adc7-4ace-a79e-40af2540d310",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.9472640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 10,
        "selector": "L10-L13",
        "symbol": "ProtectedError"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "c925367e-c776-4a97-b3a7-9eafa45060e1",
  "subject_name": "django/db/models/deletion::ProtectedError",
  "tags": [
    "entity:class"
  ],
  "text": "class ProtectedError(IntegrityError)"
}
```
