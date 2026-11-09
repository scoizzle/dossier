# Fact 127cf932

Store id: 2b27882f-c7ce-4857-af33-fbd0b4d6bf81

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
- posted_at: `2026-11-09T23:44:50.8100840+00:00`

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
  "id": "2b27882f-c7ce-4857-af33-fbd0b4d6bf81",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.8100840+00:00"
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
  "subject_id": "f6ee63a3-2d04-4433-9f92-72a85964e207",
  "subject_name": "django/db/models/fields/generated::GeneratedField._check_persistence",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_persistence(self, databases)"
}
```
