# Fact 6a5d08fd

Store id: 2fbd1b65-a672-48ff-94fa-dfd979ca22a0

## Text

```text
def _check_supported(self, databases)
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
- posted_at: `2026-11-09T22:39:43.4374930+00:00`

## Data

```json
{
  "end_line": 148,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 121,
  "symbol": "GeneratedField._check_supported"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":121,"selector":"L121-L148","symbol":"GeneratedField._check_supported"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField._check_supported](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 148,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 121,
    "symbol": "GeneratedField._check_supported"
  },
  "id": "2fbd1b65-a672-48ff-94fa-dfd979ca22a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.4374930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 121,
        "selector": "L121-L148",
        "symbol": "GeneratedField._check_supported"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "70691d50-42e6-4fde-b8fc-c3ef37d62066",
  "subject_name": "django/db/models/fields/generated::GeneratedField._check_supported",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_supported(self, databases)"
}
```
