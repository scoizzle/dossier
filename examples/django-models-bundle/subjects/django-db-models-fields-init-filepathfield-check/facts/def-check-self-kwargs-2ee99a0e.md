# Fact 2ee99a0e

Store id: 96317fd6-0a5a-4ef7-b100-316b4139aaba

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
- posted_at: `2026-11-09T22:39:42.5059000+00:00`

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
  "id": "96317fd6-0a5a-4ef7-b100-316b4139aaba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5059000+00:00"
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
  "subject_id": "2fc753c6-9cc7-4604-9862-a1ec7466f30c",
  "subject_name": "django/db/models/fields/__init__::FilePathField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
