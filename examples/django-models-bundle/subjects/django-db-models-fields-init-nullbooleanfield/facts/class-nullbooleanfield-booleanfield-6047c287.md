# Fact 6047c287

Store id: c4f7e363-96e6-4ad1-bffc-7d43f120e232

## Text

```text
class NullBooleanField(BooleanField)
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
- posted_at: `2026-11-09T23:31:56.7536590+00:00`

## Data

```json
{
  "end_line": 2411,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2387,
  "symbol": "NullBooleanField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2387,"selector":"L2387-L2411","symbol":"NullBooleanField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::NullBooleanField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2411,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2387,
    "symbol": "NullBooleanField"
  },
  "id": "c4f7e363-96e6-4ad1-bffc-7d43f120e232",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7536590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2387,
        "selector": "L2387-L2411",
        "symbol": "NullBooleanField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "8897c3b8-2bef-413e-ade8-0faa2980ac3e",
  "subject_name": "django/db/models/fields/__init__::NullBooleanField",
  "tags": [
    "entity:class"
  ],
  "text": "class NullBooleanField(BooleanField)"
}
```
