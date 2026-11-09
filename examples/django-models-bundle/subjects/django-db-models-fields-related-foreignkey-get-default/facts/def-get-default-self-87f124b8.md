# Fact 87f124b8

Store id: 06c4e69d-dd2a-492f-999d-4046a3fc515f

## Text

```text
def get_default(self)
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
- posted_at: `2026-11-09T23:31:58.7665320+00:00`

## Data

```json
{
  "end_line": 1271,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1266,
  "symbol": "ForeignKey.get_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1266,"selector":"L1266-L1271","symbol":"ForeignKey.get_default"}`

## Items

```json
[
  {
    "text": "Return the to_field if the default value is an object.",
    "locator": {
      "line": 1267
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.get_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1271,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1266,
    "symbol": "ForeignKey.get_default"
  },
  "id": "06c4e69d-dd2a-492f-999d-4046a3fc515f",
  "items": [
    {
      "locator": {
        "line": 1267
      },
      "text": "Return the to_field if the default value is an object."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7665320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1266,
        "selector": "L1266-L1271",
        "symbol": "ForeignKey.get_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "389d46a6-9888-413d-8450-218759baaf4b",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_default",
  "tags": [
    "entity:method"
  ],
  "text": "def get_default(self)"
}
```
