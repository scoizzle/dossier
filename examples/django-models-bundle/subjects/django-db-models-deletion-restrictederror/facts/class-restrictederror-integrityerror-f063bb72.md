# Fact f063bb72

Store id: 199d67f2-9877-4e86-90e5-6383a1cd5680

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
- posted_at: `2026-11-09T22:39:40.9807090+00:00`

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
  "id": "199d67f2-9877-4e86-90e5-6383a1cd5680",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.9807090+00:00"
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
  "subject_id": "e2db58ad-d5ae-4476-aae7-5cc35a6c7e0c",
  "subject_name": "django/db/models/deletion::RestrictedError",
  "tags": [
    "entity:class"
  ],
  "text": "class RestrictedError(IntegrityError)"
}
```
