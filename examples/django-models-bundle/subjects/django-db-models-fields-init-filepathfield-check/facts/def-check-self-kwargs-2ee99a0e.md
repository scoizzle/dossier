# Fact 2ee99a0e

Store id: aed7829f-e94e-4e4d-ac26-9dafbd41a044

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
- posted_at: `2026-11-09T23:31:56.6721610+00:00`

## Data

```json
{
  "end_line": 2046,
  "entity_kind": "method",
  "parent": "FilePathField",
  "start_line": 2042,
  "symbol": "FilePathField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2042,"selector":"L2042-L2046","symbol":"FilePathField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FilePathField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2046,
    "entity_kind": "method",
    "parent": "FilePathField",
    "start_line": 2042,
    "symbol": "FilePathField.check"
  },
  "id": "aed7829f-e94e-4e4d-ac26-9dafbd41a044",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6721610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2042,
        "selector": "L2042-L2046",
        "symbol": "FilePathField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "6d3a0fa2-eba5-447e-8cfe-4b9b48d30c6a",
  "subject_name": "django/db/models/fields/__init__::FilePathField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
