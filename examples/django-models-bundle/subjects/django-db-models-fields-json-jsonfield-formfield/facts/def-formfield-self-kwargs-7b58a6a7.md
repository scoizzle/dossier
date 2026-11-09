# Fact 7b58a6a7

Store id: e1fafcd0-6cb5-4442-8a9a-34bcc7d747e5

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
- posted_at: `2026-11-09T23:44:50.9508800+00:00`

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
  "id": "e1fafcd0-6cb5-4442-8a9a-34bcc7d747e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9508800+00:00"
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
  "subject_id": "7c0931c8-d95f-4bab-b1aa-a2b8d7df375b",
  "subject_name": "django/db/models/fields/json::JSONField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
