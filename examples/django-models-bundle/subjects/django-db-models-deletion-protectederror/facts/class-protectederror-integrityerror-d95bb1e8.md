# Fact d95bb1e8

Store id: d12cf989-d213-490e-96b2-ff9b07a98756

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
- posted_at: `2026-11-09T23:31:54.9883690+00:00`

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
  "id": "d12cf989-d213-490e-96b2-ff9b07a98756",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.9883690+00:00"
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
  "subject_id": "68010fea-7d3f-467d-938b-d7b6801910c8",
  "subject_name": "django/db/models/deletion::ProtectedError",
  "tags": [
    "entity:class"
  ],
  "text": "class ProtectedError(IntegrityError)"
}
```
