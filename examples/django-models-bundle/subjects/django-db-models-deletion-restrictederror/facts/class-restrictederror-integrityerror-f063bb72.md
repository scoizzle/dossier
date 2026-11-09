# Fact f063bb72

Store id: 6b56ce59-1d8f-46f6-877c-a89d70d79a0e

## Text

```text
class RestrictedError(IntegrityError)
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
- posted_at: `2026-11-09T23:44:48.8972610+00:00`

## Data

```json
{
  "end_line": 19,
  "entity_kind": "class",
  "parent": "deletion",
  "start_line": 16,
  "symbol": "RestrictedError"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":16,"selector":"L16-L19","symbol":"RestrictedError"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::RestrictedError](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 19,
    "entity_kind": "class",
    "parent": "deletion",
    "start_line": 16,
    "symbol": "RestrictedError"
  },
  "id": "6b56ce59-1d8f-46f6-877c-a89d70d79a0e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.8972610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 16,
        "selector": "L16-L19",
        "symbol": "RestrictedError"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "9931a8ca-6395-4fc1-98cb-8b809b6611da",
  "subject_name": "django/db/models/deletion::RestrictedError",
  "tags": [
    "entity:class"
  ],
  "text": "class RestrictedError(IntegrityError)"
}
```
