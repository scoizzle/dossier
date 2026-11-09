# Fact 7b58a6a7

Store id: 86a2854c-f3f2-43aa-99cb-f0b0971bc2a1

## Text

```text
def formfield(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:57.8606650+00:00`

## Data

```json
{
  "end_line": 150,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 142,
  "symbol": "JSONField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":142,"selector":"L142-L150","symbol":"JSONField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 150,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 142,
    "symbol": "JSONField.formfield"
  },
  "id": "86a2854c-f3f2-43aa-99cb-f0b0971bc2a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8606650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 142,
        "selector": "L142-L150",
        "symbol": "JSONField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "0fe8a6b7-e5b4-4c90-9882-34dd38caa40a",
  "subject_name": "django/db/models/fields/json::JSONField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
