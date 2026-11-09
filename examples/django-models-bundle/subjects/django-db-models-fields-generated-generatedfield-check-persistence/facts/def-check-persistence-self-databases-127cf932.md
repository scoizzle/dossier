# Fact 127cf932

Store id: be0dd1f3-746d-4ee8-9b9c-857d281452ae

## Text

```text
def _check_persistence(self, databases)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.6386790+00:00`

## Data

```json
{
  "end_line": 189,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 150,
  "symbol": "GeneratedField._check_persistence"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":150,"selector":"L150-L189","symbol":"GeneratedField._check_persistence"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField._check_persistence](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 189,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 150,
    "symbol": "GeneratedField._check_persistence"
  },
  "id": "be0dd1f3-746d-4ee8-9b9c-857d281452ae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.6386790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 150,
        "selector": "L150-L189",
        "symbol": "GeneratedField._check_persistence"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "584d4399-1c00-470a-af72-febff108ce96",
  "subject_name": "django/db/models/fields/generated::GeneratedField._check_persistence",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_persistence(self, databases)"
}
```
