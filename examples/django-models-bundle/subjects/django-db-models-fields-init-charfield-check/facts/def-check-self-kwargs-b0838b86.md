# Fact b0838b86

Store id: 1754436f-53d6-4a8f-b0a5-a98ccace185a

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:56.5489860+00:00`

## Data

```json
{
  "end_line": 1266,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1260,
  "symbol": "CharField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1260,"selector":"L1260-L1266","symbol":"CharField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1266,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1260,
    "symbol": "CharField.check"
  },
  "id": "1754436f-53d6-4a8f-b0a5-a98ccace185a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5489860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1260,
        "selector": "L1260-L1266",
        "symbol": "CharField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c522fe4c-90c2-4599-941f-a329921542d7",
  "subject_name": "django/db/models/fields/__init__::CharField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
