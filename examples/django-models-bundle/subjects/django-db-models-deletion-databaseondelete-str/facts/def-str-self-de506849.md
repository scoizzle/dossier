# Fact de506849

Store id: df481d9c-31ce-4e5e-ac04-91b92e16c7ea

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T23:44:48.9055870+00:00`

## Data

```json
{
  "end_line": 96,
  "entity_kind": "method",
  "parent": "DatabaseOnDelete",
  "start_line": 95,
  "symbol": "DatabaseOnDelete.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":95,"selector":"L95-L96","symbol":"DatabaseOnDelete.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::DatabaseOnDelete.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 96,
    "entity_kind": "method",
    "parent": "DatabaseOnDelete",
    "start_line": 95,
    "symbol": "DatabaseOnDelete.__str__"
  },
  "id": "df481d9c-31ce-4e5e-ac04-91b92e16c7ea",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9055870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 95,
        "selector": "L95-L96",
        "symbol": "DatabaseOnDelete.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "b2c9b482-5830-43a8-ae6a-59dcb9846706",
  "subject_name": "django/db/models/deletion::DatabaseOnDelete.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
