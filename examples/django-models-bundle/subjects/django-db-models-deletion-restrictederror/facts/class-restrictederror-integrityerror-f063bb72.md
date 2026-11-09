# Fact f063bb72

Store id: b4a3c917-1dd1-4abd-8f35-f6efc8c23b18

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
- posted_at: `2026-11-09T23:31:55.0217580+00:00`

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
  "id": "b4a3c917-1dd1-4abd-8f35-f6efc8c23b18",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0217580+00:00"
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
  "subject_id": "038549c6-3872-47c4-b9e8-c2e4c334a88f",
  "subject_name": "django/db/models/deletion::RestrictedError",
  "tags": [
    "entity:class"
  ],
  "text": "class RestrictedError(IntegrityError)"
}
```
